using EmployerManagementSystem.Controllers;
using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Test.MockData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EmployerManagementSystem.Test.Controllers
{
    public class EmployeeControllerTest
    {

        [Fact]
        public void GetAll_ValidResultAsync()
        {
            IEmployeeRepository employeeRepository = new MockEmployeeRepository();
            IAddressRepository addressRepository = new MockAddressRepository();
            var employeeController = new EmployeeController(employeeRepository, addressRepository);
            var result = employeeController.GetAll();
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAddress()
        {
            IEmployeeRepository employeeRepository = new MockEmployeeRepository();
            IAddressRepository addressRepository = new MockAddressRepository();
            var employeeController = new EmployeeController(employeeRepository, addressRepository);
            var result = employeeController.GetAddressById(1);
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
