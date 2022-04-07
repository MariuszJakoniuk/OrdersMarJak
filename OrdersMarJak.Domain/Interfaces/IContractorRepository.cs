namespace OrdersMarJak.Domain.Interfaces;

public interface IContractorRepository
{
    int AddContractor(Contractor contractor);

    bool DeleteContractor(int contractorId);

    IQueryable<Contractor> GetAllContractor();

    Contractor GetContractorById(int contractorId);

    bool UpdateContractor(Contractor contractor);
}
