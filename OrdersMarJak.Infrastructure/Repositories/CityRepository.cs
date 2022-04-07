namespace OrdersMarJak.Infrastructure.Repositories;

public class CityRepository: ICityRepository
{
    private readonly Context _context;
    public CityRepository(Context context)
    {
        _context = context;
    }

    public int AddCity(City city)
    {
        city.UserAdd = "userSymbol";
        city.DateAdd = DateTime.Now;
        city.IsDeleted = false;
        _context.Cities.Add(city);
        _context.SaveChanges();
        return city.Id;
    }

    public bool DeleteCity(int cityId)
    {
        var city = _context.Cities.FirstOrDefault(c => c.Id == cityId);
        if (city != null)
        {
            city.UserDelete = "userSymbol";
            city.DateDelete = DateTime.Now;
            city.IsDeleted = true;
            _context.Attach(city);
            _context.Entry(city).Property("UserDelete").IsModified = true;
            _context.Entry(city).Property("DateDelete").IsModified = true;
            _context.Entry(city).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<City> GetAllCity()
    {
        var city = _context.Cities.Where(w => w.IsDeleted == false);
        return city;
    }

    public City GetCityById(int cityId)
    {
        var city = _context.Cities.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == cityId);
        return city;
    }

    public bool UpdateCity(City city)
    {
        city.UserUpdate = "userSymbol";
        city.DateUpdate = DateTime.Now;
        _context.Attach(city);
        _context.Entry(city).Property("Name").IsModified = true;
        _context.Entry(city).Property("UserUpdate").IsModified = true;
        _context.Entry(city).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
