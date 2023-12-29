using EmployerManagementSystem.Data.IRepository;
using EmployerManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployerManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IAddressRepository _addressRepository;
        public EmployeeController(IEmployeeRepository employeeRepository, IAddressRepository addressRepository)
        {
            _employeeRepository = employeeRepository;
            _addressRepository = addressRepository;

        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var employee = _employeeRepository.GetAll();
            ApiResponse<List<Employee>> apiResponse;
            if (employee.Any())
            {
                apiResponse = new(true, string.Empty, employee);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Data not found", employee);
                return NotFound(apiResponse);
            }            
        }

        [HttpGet("GetEmployeByName")]
        public IActionResult GetEmployeByName([FromQuery] string name)
        {
            var employee = _employeeRepository.GetEmployeByName(name);
            ApiResponse<List<Employee>> apiResponse;
            if (employee.Any())
            {
                apiResponse = new(true, string.Empty, employee);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Data not found", employee);
                return NotFound(apiResponse);
            }
        }

        [HttpGet("GetEmployeeById")]
        public IActionResult GetEmployeeById([FromQuery] int employeeId)
        {
            var employee = _employeeRepository.GetEmployeeById(employeeId);
            ApiResponse<Employee> apiResponse;
            if (employee != null)
            {
                apiResponse = new(true, string.Empty, employee);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Data not found", employee);
                return NotFound(apiResponse);
            }
        }


        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            var result = _employeeRepository.AddEmployee(employee);
            ApiResponse<Employee> apiResponse;
            if (result)
            {
                apiResponse = new(true, "Employee Added Successfully", employee);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Bad Request", null);
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("DeleteEmployee")]
        public IActionResult DeleteEmployee([FromBody] int employeeId)
        {
            var result = _employeeRepository.DeleteEmployee(employeeId);
            ApiResponse<Employee> apiResponse;
            if (result)
            {
                apiResponse = new(true, "Employee Deleted Successfully", null);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Bad Request", null);
                return BadRequest(apiResponse);
            }
        }


        [HttpGet("GetAddressById")]
        public IActionResult GetAddressById([FromQuery] int addressById)
        {
            var address = _addressRepository.GetAddressById(addressById);
            ApiResponse<Address> apiResponse;
            if (address != null)
            {
                apiResponse = new(true, string.Empty, address);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Data not found", address);
                return NotFound(apiResponse);
            }
        }


        [HttpPost("AddAddress")]
        public IActionResult AddAddress([FromBody] Address address)
        {
            var result = _addressRepository.AddAddress(address);
            ApiResponse<Address> apiResponse;
            if (result)
            {
                apiResponse = new(true, "Address Added Successfully", address);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Bad Request", null);
                return BadRequest(apiResponse);
            }
        }

        [HttpPost("DeleteAddress")]
        public IActionResult DeleteAddress([FromBody] int addressById)
        {
            var result = _addressRepository.DeleteAddress(addressById);
            ApiResponse<Address> apiResponse;
            if (result)
            {
                apiResponse = new(true, "Address Deleted Successfully", null);
                return Ok(apiResponse);
            }
            else
            {
                apiResponse = new(false, "Bad Request", null);
                return BadRequest(apiResponse);
            }
        }
    }
}
