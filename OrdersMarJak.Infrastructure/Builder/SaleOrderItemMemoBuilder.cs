namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderItemMemoBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrderItemMemo>(eb =>
        {
            eb.Property(c => c.MemoDate).HasColumnType("date");

            eb.HasOne(d => d.SaleOrderItem).WithMany(p => p.SaleOrderItemMemos).OnDelete(DeleteBehavior.NoAction);
        });
    }
}