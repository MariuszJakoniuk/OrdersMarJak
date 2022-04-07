namespace OrdersMarJak.Domain.Model;
public class ContractorAddress : AuditableModel
{
    public string Name { get; set; }
    public string? Comment { get; set; }
    public bool ToInvoice { get; set; }


    public int ContractorId { get; set; }
    public Contractor Contractor { get; set; }

    public int? CountryId { get; set; }
    public Country? Country { get; set; }

    public int? CityId { get; set; }
    public City? City { get; set; }

    public int? StreetId { get; set; }
    public Street? Street { get; set; }

    public string? Number { get; set; }
    public string? ZipCode { get; set; }

    public int? PostOfficeId { get; set; }
    public City? PostOffice { get; set; }
}