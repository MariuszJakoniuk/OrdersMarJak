namespace OrdersMarJak.Infrastructure.Buider;
public class EmployeeBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(eb =>
        {
            eb.Property(c => c.Symbol).HasColumnType("nvarchar(10)");
            eb.HasIndex(i => i.Symbol).IsUnique();

            eb.HasMany(d => d.EmployeeGroups).WithMany(p => p.Employees);
        });
    }
}