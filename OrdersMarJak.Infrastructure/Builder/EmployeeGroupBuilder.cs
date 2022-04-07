namespace OrdersMarJak.Infrastructure.Buider;
public class EmployeeGroupBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeGroup>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
            eb.Property(e => e.Sort).HasDefaultValue(99);
        });
    }
}