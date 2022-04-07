namespace OrdersMarJak.Infrastructure.Buider;
public class CityBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<City>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
        });
    }
}