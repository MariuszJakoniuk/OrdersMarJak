namespace OrdersMarJak.Domain.Model;
public class Employee : AuditableModel
{
    public string Symbol { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public bool AllowedSaleOrderItemsDate { get; set; }

    public virtual ICollection<EmployeeGroup> EmployeeGroups{ get; set; }
    public virtual ICollection<SaleOrderItemDate> SaleOrderItemDates{ get; set; }
}