namespace OrdersMarJak.Domain.Model;
public class SaleOrderPay : AuditableModel
{
    public DateTime DatePay { get; set; }
    public decimal Pay { get; set; }
    public string Name { get; set; }
    public string? Remarks { get; set; }

    public int SaleOrderId { get; set; }
    public SaleOrder SaleOrder { get; set; }
}