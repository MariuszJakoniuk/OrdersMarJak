namespace OrdersMarJak.Domain.Model;
public class EmployeeGroup : AuditableModel
{
    public string Name { get; set; }
    public byte Sort { get; set; }

    public virtual ICollection<Employee> Employees { get; set; }
    public virtual ICollection<SaleOrderItemDate> SaleOrderItemDates { get; set; }
}