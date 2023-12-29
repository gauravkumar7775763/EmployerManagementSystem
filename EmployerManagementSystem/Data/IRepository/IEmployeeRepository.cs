using EmployerManagementSystem.Models;

namespace EmployerManagementSystem.Data.IRepository
{
    public interface IEmployeeRepository
    {
        bool AddEmployee(Employee employee);
        bool DeleteEmployee(int employeeId);
        Employee GetEmployeeById(int employeeId);
        List<Employee> GetAll();
        List<Employee> GetEmployeByName(string name);
    }
}
