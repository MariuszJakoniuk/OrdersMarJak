namespace OrdersMarJak.Infrastructure.Repositories;

public class EmployeeGroupRepository: IEmployeeGroupRepository
{
    private readonly Context _context;
    public EmployeeGroupRepository(Context context)
    {
        _context = context;
    }

    public int AddEmployeeGroup(EmployeeGroup employeeGroup)
    {
        employeeGroup.UserAdd = "userSymbol";
        employeeGroup.DateAdd = DateTime.Now;
        employeeGroup.IsDeleted = false;
        _context.EmployeeGroups.Add(employeeGroup);
        _context.SaveChanges();
        return employeeGroup.Id;
    }

    public bool DeleteEmployeeGroup(int employeeGroupId)
    {
        var employeeGroup = _context.EmployeeGroups.FirstOrDefault(c => c.Id == employeeGroupId);
        if (employeeGroup != null)
        {
            employeeGroup.UserDelete = "userSymbol";
            employeeGroup.DateDelete = DateTime.Now;
            employeeGroup.IsDeleted = true;
            _context.Attach(employeeGroup);
            _context.Entry(employeeGroup).Property("UserDelete").IsModified = true;
            _context.Entry(employeeGroup).Property("DateDelete").IsModified = true;
            _context.Entry(employeeGroup).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<EmployeeGroup> GetAllEmployeeGroup()
    {
        var employeeGroup = _context.EmployeeGroups.Where(w => w.IsDeleted == false);
        return employeeGroup;
    }

    public EmployeeGroup GetEmployeeGroupById(int employeeGroupId)
    {
        var employeeGroup = _context.EmployeeGroups.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == employeeGroupId);
        return employeeGroup;
    }

    public bool UpdateEmployeeGroup(EmployeeGroup employeeGroup)
    {
        employeeGroup.UserUpdate = "userSymbol";
        employeeGroup.DateUpdate = DateTime.Now;
        _context.Attach(employeeGroup);
        _context.Entry(employeeGroup).Property("Name").IsModified = true;
        _context.Entry(employeeGroup).Property("Sort").IsModified = true;
        _context.Entry(employeeGroup).Property("UserUpdate").IsModified = true;
        _context.Entry(employeeGroup).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
