namespace OrdersMarJak.Domain.Model;
public class SaleOrder : AuditableModel
{
    public short Year { get; set; } = (short)DateTime.Now.Year;
    public int Number { get; set; }
    public string NumberFull { get; set; }
    public string NumberShort { get; set; }
    public string NumberInContractor { get; set; }
    public DateTime DateIn { get; set; }
    public string Name { get; set; }
    public DateTime? DateSigning { get; set; }
    public DateTime? DateDeadline { get; set; }
    public DateTime? DateEnd { get; set; }
    public decimal Brutto { get; set; }
    public decimal Netto { get; set; }
    public decimal Paid { get; set; }
    public decimal LeftPay { get; set; }
    public string? Remarks { get; set; }

    public int ContractorId { get; set; }
    public Contractor Contractor { get; set; }

    public int SaleOrderRegisterId { get; set; }
    public SaleOrderRegister SaleOrderRegister { get; set; }

    public int SaleOrderStatusId { get; set; }
    public SaleOrderStatus SaleOrderStatus { get; set; }

    public virtual ICollection<SaleOrderPay> SaleOrderPays { get; set; }
    public virtual ICollection<SaleOrderItem> SaleOrderItems { get; set; }
}