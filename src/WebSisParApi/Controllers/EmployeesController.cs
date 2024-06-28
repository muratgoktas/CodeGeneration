using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSisParApi.Dtos.EmployeeDtos;
using WebSisParApi.Repositories.EmployeeRepository;

namespace WebSisParApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
       [HttpGet]
       public async Task<IActionResult> EmployeeList() 
        {
         var values = await _employeeRepository.GetAllEmployeeAsync();
            return Ok(values);

        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee (CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Employee created.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee (int id)
        {
            _employeeRepository.DeleteEmployee(id);
            return Ok("Employee deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Employee Updated.");

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee (int id)
        {
            var value = await _employeeRepository.GetEmployeeAsync(id);
            return Ok(value);
        }

    }
}
