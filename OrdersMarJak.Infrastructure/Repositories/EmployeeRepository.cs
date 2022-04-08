namespace OrdersMarJak.Infrastructure.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly Context _context;
    public EmployeeRepository(Context context)
    {
        _context = context;
    }

    public int AddEmployee(Employee employee)
    {
        employee.UserAdd = "userSymbol";
        employee.DateAdd = DateTime.Now;
        employee.IsDeleted = false;
        _context.Employees.Add(employee);
        _context.SaveChanges();
        return employee.Id;
    }

    public bool DeleteEmployee(int employeeId)
    {
        var employee = _context.Employees.FirstOrDefault(c => c.Id == employeeId);
        if (employee != null)
        {
            employee.UserDelete = "userSymbol";
            employee.DateDelete = DateTime.Now;
            employee.IsDeleted = true;
            _context.Attach(employee);
            _context.Entry(employee).Property("UserDelete").IsModified = true;
            _context.Entry(employee).Property("DateDelete").IsModified = true;
            _context.Entry(employee).Property("IsDeleted").IsModified = true;
            _context.SaveChanges();
            return true;
        }
        return false;
    }

    public IQueryable<Employee> GetAllEmployee()
    {
        var employee = _context.Employees.Where(w => w.IsDeleted == false);
        return employee;
    }

    public Employee GetEmployeeById(int employeeId)
    {
        var employee = _context.Employees.Where(w => w.IsDeleted == false).FirstOrDefault(c => c.Id == employeeId);
        return employee;
    }

    public bool UpdateEmployee(Employee employee)
    {
        employee.UserUpdate = "userSymbol";
        employee.DateUpdate = DateTime.Now;
        _context.Attach(employee);
        _context.Entry(employee).Property("Symbol").IsModified = true;
        _context.Entry(employee).Property("FirstName").IsModified = true;
        _context.Entry(employee).Property("LastName").IsModified = true;
        _context.Entry(employee).Property("FullName").IsModified = true;
        _context.Entry(employee).Property("AllowedSaleOrderItemsDate").IsModified = true;
        _context.Entry(employee).Property("UserUpdate").IsModified = true;
        _context.Entry(employee).Property("DateUpdate").IsModified = true;
        _context.SaveChanges();
        return true;
    }
}
