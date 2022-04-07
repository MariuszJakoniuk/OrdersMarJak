namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderItemBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderItem>(eb =>
        {
            eb.Property(c => c.ItemChar).HasColumnType("nvarchar(3)");
            eb.Property(d => d.IsReclamation).HasDefaultValue(false);
            eb.HasIndex(i => i.Name);
            eb.Property(b => b.Brutto).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            eb.Property(b => b.Netto).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            
            eb.HasOne(d => d.SaleOrder).WithMany(p => p.SaleOrderItems).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.SaleOrderItemStatus).WithMany(p => p.SaleOrderItems).OnDelete(DeleteBehavior.NoAction);

        });
    }
}