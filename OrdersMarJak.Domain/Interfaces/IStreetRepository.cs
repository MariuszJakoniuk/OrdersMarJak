namespace OrdersMarJak.Domain.Interfaces;

public interface IStreetRepository
{
    int AddStreet(Street street);

    bool DeleteStreet(int streetId);

    IQueryable<Street> GetAllStreet();

    Street GetStreetById(int streetId);

    bool UpdateStreet(Street street);
}
