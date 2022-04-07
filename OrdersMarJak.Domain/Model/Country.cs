namespace OrdersMarJak.Domain.Model;
public class Country : AuditableModel
{
    public string Symbol { get; set; }
    public string Name { get; set; }
    public bool IsUE { get; set; }

    public virtual ICollection<ContractorAddress> ContractorAddresses { get; set; }
}