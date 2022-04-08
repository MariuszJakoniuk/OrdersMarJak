namespace OrdersMarJak.Infrastructure.Repositories;

public class CountryRepository: ICountryRepository
{
    private readonly Context _context;
    public CountryRepository(Context context)
    {
        _context = context;
    }

    public int AddCountry(Country country)
    {
        country.UserAdd = "userSymbol";
        country.DateAdd = DateTime.Now;
        country.IsDeleted = false;
        _context.Countries.Add(country);
        _context.SaveChanges();
        return country.Id;
    }

    public bool DeleteCountry(int countryId)
    {
        var country = _context.Countries.FirstOrDefault(c => c.Id == countryId);
        if (country != null)
        {
            country.UserDelete = "userSymbol";
            country.DateDelete = DateTime.Now;
            country.IsDeleted = true;
            _context.Attach(country);
            _context.Entry(country).Property("UserDelete").IsModified = true;
            _context.Entry(country).Property("DateDelete").IsModified = true;
            _context.Entry(country).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<Country> GetAllCountry()
    {
        var country = _context.Countries.Where(w => w.IsDeleted == false);
        return country;
    }

    public Country GetCountryById(int countryId)
    {
        var country = _context.Countries.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == countryId);
        return country;
    }

    public bool UpdateCountry(Country country)
    {
        country.UserUpdate = "userSymbol";
        country.DateUpdate = DateTime.Now;
        _context.Attach(country);
        _context.Entry(country).Property("Symbol").IsModified = true;
        _context.Entry(country).Property("Name").IsModified = true;
        _context.Entry(country).Property("IsUE").IsModified = true;
        _context.Entry(country).Property("UserUpdate").IsModified = true;
        _context.Entry(country).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
