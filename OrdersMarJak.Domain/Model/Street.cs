namespace OrdersMarJak.Domain.Model;
public class Street : AuditableModel
{
    public string Name { get; set; }

    public virtual ICollection<ContractorAddress> ContractorAddresses { get; set; }
}