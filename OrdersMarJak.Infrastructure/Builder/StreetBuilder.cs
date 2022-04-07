namespace OrdersMarJak.Infrastructure.Buider;
public class StreetBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Street>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
        });
    }
}