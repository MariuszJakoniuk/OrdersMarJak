namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderPayBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderPay>(eb =>
        {
            eb.Property(c => c.DatePay).HasColumnType("date");
            eb.Property(b => b.Pay).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
        });
    }
}