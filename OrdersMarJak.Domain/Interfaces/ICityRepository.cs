namespace OrdersMarJak.Domain.Interfaces;

public interface ICityRepository
{
    int AddCity(City city);

    bool DeleteCity(int cityId);

    IQueryable<City> GetAllCity();

    City GetCityById(int cityId);

    bool UpdateCity(City city);
}
