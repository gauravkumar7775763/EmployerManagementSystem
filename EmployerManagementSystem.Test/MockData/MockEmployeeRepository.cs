using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployerManagementSystem.Test.MockData
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        public bool AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            var employeeList = new List<Employee>();
            employeeList.Add(new Employee
            {
                EmployeeId = 1,
                FirstName = "Gaurav",
                LastName = "Thakur",
                Age = 30,
                EmailAddress = "gaurav.thakur@gmail.com",
                CreatedAt = DateTime.Now,
                LastModifiedAt = DateTime.Now,
                CreatedBy = "Seeder",
                ModifiedBy = "Seeder",
                AddressId = 1
            });
            return employeeList;
        }

        public List<Employee> GetEmployeByName(string name)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
