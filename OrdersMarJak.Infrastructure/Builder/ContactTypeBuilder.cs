namespace OrdersMarJak.Infrastructure.Buider;
public class ContactTypeBuilder
{
    public void Builder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ContactType>(eb =>
        {
            eb.HasIndex(i => i.Name).IsUnique();
        });
    }
}