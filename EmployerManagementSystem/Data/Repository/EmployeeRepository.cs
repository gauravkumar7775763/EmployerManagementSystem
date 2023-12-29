using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployerManagementSystem.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public bool AddEmployee(Employee employee)
        {
            _context.Add(employee);
            var result = _context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteEmployee(int employeeId)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            if(employee != null)
            {
                _context.Remove(employee);
                var result = _context.SaveChanges();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.Include(i => i.Address).Select(x => x).ToList();
        }

        public List<Employee> GetEmployeByName(string name)
        {
            if(name.Length > 2)
            {
                return _context.Employees.Include(i => i.Address).Where(x => (x.FirstName + " " + x.LastName).ToLower().Contains(name.Trim().ToLower())).ToList();
            }
            else
            {
                return null;
            }
            
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _context.Employees.Include(i => i.Address).FirstOrDefault(x => x.EmployeeId == employeeId);
        }
    }
}
