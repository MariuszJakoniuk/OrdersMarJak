namespace OrdersMarJak.Domain.Model;
public class SaleOrderItemDate : AuditableModel
{
    public DateTime DateIn { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public string Comment { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
    public int EmployeeGroupId { get; set; }
    public EmployeeGroup EmployeeGroup { get; set; }

    public int SaleOrderItemId { get; set; }
    public SaleOrderItem SaleOrderItem { get; set; }
}