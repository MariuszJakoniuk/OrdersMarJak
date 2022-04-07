namespace OrdersMarJak.Infrastructure.Buider;
public class CountryBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(eb =>
        {
            eb.Property(c => c.Symbol).HasColumnType("nvarchar(3)");
            eb.HasIndex(i => i.Symbol).IsUnique();
            eb.HasIndex(i => i.Name).IsUnique();
            eb.Property(d => d.IsUE).HasDefaultValue(true);
        });
    }
}