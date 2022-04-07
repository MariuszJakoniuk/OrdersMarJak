namespace OrdersMarJak.Domain.Model;
public class Contractor : AuditableModel
{
    public bool IsCompany { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string? Nip { get; set; }


    public virtual ICollection<SaleOrder> SaleOrders { get; set; }
    public virtual ICollection<ContractorContact> ContractorContacts { get; set; }
    public virtual ICollection<ContractorAddress> ContractorAddresses { get; set; }
}