namespace OrdersMarJak.Domain.Common;
public class AuditableModel
{
    public int Id { get; set; }
    public string UserAdd { get; set; }
    public DateTime DateAdd { get; set; }
    public string? UserUpdate { get; set; }
    public DateTime? DateUpdate { get; set; }
    public string? UserDelete { get; set; }
    public DateTime? DateDelete { get; set; }
    public bool IsDeleted { get; set; }
}
