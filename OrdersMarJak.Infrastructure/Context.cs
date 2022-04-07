namespace OrdersMarJak.Infrastructure;
public class Context : IdentityDbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<ContactType> ContactTypes { get; set; }
    public DbSet<Contractor> Contractors { get; set; }
    public DbSet<ContractorAddress> ContractorAddresses { get; set; }
    public DbSet<ContractorContact> ContractorContacts { get; set; }
    public DbSet<Country> Countries { get; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeGroup> EmployeeGroups { get; set; }
    public DbSet<SaleOrder> SaleOrders { get; set; }
    public DbSet<SaleOrderPay> SaleOrderPays { get; set; }
    public DbSet<SaleOrderRegister> SaleOrdersRegisters { get; set; }
    public DbSet<SaleOrderStatus> SaleOrderStatuses { get; set; }
    public DbSet<Street> Streets { get; set; }
    public DbSet<SaleOrderItem> SaleOrdersItems { get; set; }
    public DbSet<SaleOrderItemDate> SaleOrderItemDates { get; set; }
    public DbSet<SaleOrderItemMemo> SaleOrderItemMemos { get; set; }
    public DbSet<SaleOrderItemStatus> SaleOrdersItemsStatus { get; set; }

    public Context(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        CityBuilder cityBuilder = new CityBuilder();
        cityBuilder.Builder(builder);

        ContactTypeBuilder contactTypeBuilder = new ContactTypeBuilder();
        contactTypeBuilder.Builder(builder);

        ContractorBuilder contractorBuilder = new ContractorBuilder();
        contractorBuilder.Builder(builder);

        ContractorAddressBuilder contractorAddressBuilder = new ContractorAddressBuilder();
        contractorAddressBuilder.Builder(builder);

        ContractorContactBuilder contractorContactBuilder = new ContractorContactBuilder();
        contractorContactBuilder.Builder(builder);

        CountryBuilder countryBuilder = new CountryBuilder();
        countryBuilder.Builder(builder);

        EmployeeBuilder employeeBuilder = new EmployeeBuilder();
        employeeBuilder.Builder(builder);

        EmployeeGroupBuilder employeeGroupBuilder = new EmployeeGroupBuilder();
        employeeGroupBuilder.Builder(builder);

        SaleOrderBuilder saleOrderBuilder = new SaleOrderBuilder();
        saleOrderBuilder.Builder(builder);

        SaleOrderPayBuilder saleOrderPayBuilder = new SaleOrderPayBuilder();
        saleOrderPayBuilder.Builder(builder);

        SaleOrderRegisterBuilder saleOrderRegisterBuilder = new SaleOrderRegisterBuilder();
        saleOrderRegisterBuilder.Builder(builder);

        SaleOrderStatusBuilder saleOrderStatusBuilder = new SaleOrderStatusBuilder();
        saleOrderStatusBuilder.Builder(builder);

        StreetBuilder streetBuilder = new StreetBuilder();
        streetBuilder.Builder(builder);

        SaleOrderItemBuilder saleOrderItemBuilder = new SaleOrderItemBuilder();
        saleOrderItemBuilder.Builder(builder);

        SaleOrderItemDateBuilder saleOrderItemDateBuilder = new SaleOrderItemDateBuilder();
        saleOrderItemDateBuilder.Builder(builder);

        SaleOrderItemMemoBuilder saleOrderItemMemoBuilder = new SaleOrderItemMemoBuilder();
        saleOrderItemMemoBuilder.Builder(builder);

        SaleOrderItemStatusBuilder saleOrderItemStatusBuilder = new SaleOrderItemStatusBuilder();
        saleOrderItemStatusBuilder.Builder(builder);

    }
}