namespace OrdersMarJak.Infrastructure.Buider;
public class ContractorAddressBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContractorAddress>(eb =>
        {   
            eb.HasIndex(c => c.Name);
            eb.Property(d => d.ToInvoice).HasDefaultValue(false);
            eb.HasOne(d => d.Contractor).WithMany(p => p.ContractorAddresses).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.Country).WithMany(p => p.ContractorAddresses).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.City).WithMany(p => p.ContractorAddressCities).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.Street).WithMany(p => p.ContractorAddresses).OnDelete(DeleteBehavior.NoAction);
            eb.HasOne(d => d.PostOffice).WithMany(p => p.ContractorAddressPostOffices).OnDelete(DeleteBehavior.NoAction);
        });
    }
}