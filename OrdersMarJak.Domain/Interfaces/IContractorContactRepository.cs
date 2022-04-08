namespace OrdersMarJak.Domain.Interfaces;

public interface IContractorContactRepository
{
    int AddContractorContact(ContractorContact contractorContact);

    bool DeleteContractorContact(int contractorContactId);

    IQueryable<ContractorContact> GetAllContractorContact();

    IQueryable<ContractorContact> GetAllContractorContactByContractorId(int contractorId);

    ContractorContact GetContractorContactById(int contractorContactId);

    bool UpdateContractorContact(ContractorContact contractorContact);
}
