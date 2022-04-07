namespace OrdersMarJak.Infrastructure.Buider;
public class SaleOrderBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SaleOrder>(eb =>
        {
            eb.Property(c => c.Year).HasDefaultValueSql("YEAR(GETDATE())");
            eb.Property(c => c.NumberFull).HasColumnType("nvarchar(22)");
            eb.HasIndex(i => i.NumberFull).IsUnique();
            eb.Property(c => c.NumberShort).HasColumnType("nvarchar(16)");
            eb.HasIndex(i => i.NumberShort).IsUnique();
            eb.Property(c => c.DateIn).HasColumnType("date");
            eb.HasIndex(i => i.Name);
            eb.Property(c => c.DateSigning).HasColumnType("date");
            eb.Property(c => c.DateDeadline).HasColumnType("date");
            eb.Property(c => c.DateEnd).HasColumnType("date");
            eb.Property(b => b.Brutto).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            eb.Property(b => b.Netto).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            eb.Property(b => b.Paid).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            eb.Property(b => b.LeftPay).HasColumnType("decimal(12, 2)").HasDefaultValue(0);
            eb.HasOne(d => d.Contractor).WithMany(p => p.SaleOrders).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.SaleOrderRegister).WithMany(p => p.SaleOrders).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.SaleOrderStatus).WithMany(p => p.SaleOrders).OnDelete(DeleteBehavior.NoAction);
        });
    }
}