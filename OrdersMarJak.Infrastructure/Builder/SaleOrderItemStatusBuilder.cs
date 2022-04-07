namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderItemStatusBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderItemStatus>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
            eb.Property(d => d.Sort).HasDefaultValue(99);
            eb.Property(d => d.IsEnd).HasDefaultValue(false);
        });
    }
}