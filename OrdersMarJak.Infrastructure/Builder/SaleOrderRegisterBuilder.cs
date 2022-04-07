namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderRegisterBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderRegister>(eb =>
        {
            eb.Property(c => c.Symbol).HasColumnType("nvarchar(3)");
            eb.HasIndex(i => i.Symbol).IsUnique();
            eb.HasIndex(i => i.Name).IsUnique();
        });
    }
}