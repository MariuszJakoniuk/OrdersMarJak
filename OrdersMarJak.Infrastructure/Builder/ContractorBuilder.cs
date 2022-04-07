namespace OrdersMarJak.Infrastructure.Buider;
public class ContractorBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contractor>(eb =>
        {
            eb.Property(d => d.IsCompany).HasDefaultValue(false);
            eb.Property(c => c.Symbol).HasColumnType("nvarchar(70)");
            eb.HasIndex(i => i.Symbol).IsUnique();
            eb.Property(c => c.Name).HasColumnType("nvarchar(240)");
            eb.HasIndex(i => i.Name).IsUnique();
            eb.Property(c => c.Nip).HasColumnType("nvarchar(14)");
            eb.HasIndex(i => i.Nip);
        });
    }
}