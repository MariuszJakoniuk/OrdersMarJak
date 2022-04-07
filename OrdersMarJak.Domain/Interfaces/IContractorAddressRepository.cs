namespace OrdersMarJak.Domain.Interfaces;

public interface IContractorAddressRepository
{
    int AddContractorAddress(ContractorAddress contractorAddress);

    bool DeleteContractorAddress(int contractorAddressId);

    IQueryable<ContractorAddress> GetAllContractorAddress();
    
    IQueryable<ContractorAddress> GetAllContractorAddressByContractorId(int contractorId);

    ContractorAddress GetContractorAddressById(int contractorAddressId);
    
    bool UpdateContractorAddress(ContractorAddress contractorAddress);
}
