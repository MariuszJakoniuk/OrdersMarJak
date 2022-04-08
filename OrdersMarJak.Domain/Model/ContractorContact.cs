namespace OrdersMarJak.Domain.Model;
public class ContractorContact : AuditableModel
{
    public string Name { get; set; }
    public bool IsPrimary { get; set; }
    public string Comment { get; set; }

    public int ContractorId { get; set; }
    public Contractor Contractor { get; set; }

    public int ContactTypeId { get; set; }
    public ContactType ContactType { get; set; }
}