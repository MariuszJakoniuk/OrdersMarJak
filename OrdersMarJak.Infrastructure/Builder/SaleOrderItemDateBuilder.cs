namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderItemDateBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderItemDate>(eb =>
        {
            eb.Property(c => c.DateIn).HasColumnType("date");
            eb.Property(c => c.DateStart).HasColumnType("date");
            eb.Property(c => c.DateEnd).HasColumnType("date");

            eb.HasOne(d => d.Employee).WithMany(p => p.SaleOrderItemDates).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.EmployeeGroup).WithMany(p => p.SaleOrderItemDates).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.SaleOrderItem).WithMany(p => p.SaleOrderItemDates).OnDelete(DeleteBehavior.NoAction);

        });
    }
}