namespace OrdersMarJak.Domain.Interfaces;

public interface IEmployeeRepository
{
    int AddEmployee(Employee employee);

    bool DeleteEmployee(int employeeId);

    IQueryable<Employee> GetAllEmployee();

    Employee GetEmployeeById(int employeeId);

    bool UpdateEmployee(Employee employee);
}
