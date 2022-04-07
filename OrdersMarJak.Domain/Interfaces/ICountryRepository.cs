namespace OrdersMarJak.Domain.Interfaces;

public interface ICountryRepository
{
    int AddCountry(Country country);

    bool DeleteCountry(int countryId);

    IQueryable<Country> GetAllCountry();

    Country GetCountryById(int countryId);

    bool UpdateCountry(Country country);
}
