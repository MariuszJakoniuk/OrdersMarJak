namespace OrdersMarJak.Domain.Interfaces;

public interface IEmployeeGroupRepository
{
    int AddEmployeeGroup(EmployeeGroup employeeGroup);

    bool DeleteEmployeeGroup(int employeeGroupId);

    IQueryable<EmployeeGroup> GetAllEmployeeGroup();

    EmployeeGroup GetEmployeeGroupById(int employeeGroupId);

    bool UpdateEmployeeGroup(EmployeeGroup employeeGroup);
}
