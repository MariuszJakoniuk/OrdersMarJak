namespace OrdersMarJak.Domain.Model;
public class SaleOrderItemMemo : AuditableModel
{
    public DateTime MemoDate { get; set; }
    public string Memo { get; set; }

    public int SaleOrderItemId { get; set; }
    public SaleOrderItem SaleOrderItem { get; set; }
}