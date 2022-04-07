namespace OrdersMarJak.Domain.Model;
public class ContactType : AuditableModel
{
    public string Name { get; set; }

    public virtual ICollection<ContractorContact> ContractorContacts { get; set; }
}