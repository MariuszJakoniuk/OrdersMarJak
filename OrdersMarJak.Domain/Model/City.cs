namespace OrdersMarJak.Domain.Model;
public class City : AuditableModel
{
    public string Name { get; set; }

    public virtual ICollection<ContractorAddress> ContractorAddressCities{ get; set; }
    public virtual ICollection<ContractorAddress> ContractorAddressPostOffices { get; set; }
}