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
         var values = await _employeeRepository.GetAllAsync();
            return Ok(values);

        }
        [HttpPost]
        public async Task<IActionResult> Create (CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.Create(createEmployeeDto);
            return Ok("Employee created.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete (int id)
        {
            _employeeRepository.Delete(id);
            return Ok("Employee deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.Update(updateEmployeeDto);
            return Ok("Employee Updated.");

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee (int id)
        {
            var value = await _employeeRepository.GetByIdAsync(id);
            return Ok(value);
        }

    }
}
