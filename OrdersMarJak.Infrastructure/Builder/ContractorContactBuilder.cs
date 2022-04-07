namespace OrdersMarJak.Infrastructure.Buider;
public class ContractorContactBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContractorContact>(eb =>
        {
            eb.Property(d => d.IsPrimary).HasDefaultValue(false);
            eb.Property(c => c.Name).HasColumnType("nvarchar(240)");
            eb.HasOne(d => d.Contractor).WithMany(p => p.ContractorContacts).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.ContactType).WithMany(p => p.ContractorContacts).OnDelete(DeleteBehavior.NoAction);
        });
    }
}