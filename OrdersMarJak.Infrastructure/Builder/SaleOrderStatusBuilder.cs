namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderStatusBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderStatus>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
            eb.Property(d => d.Sort).HasDefaultValue(99);
            eb.Property(d => d.IsEnd).HasDefaultValue(false);
            eb.Property(d => d.IsCanceled).HasDefaultValue(false);
        });
    }
}