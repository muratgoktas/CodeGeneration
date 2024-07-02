using WebSisPar.Dtos.EmployeeDtos;



namespace WebSisPar.Controllers;

public class EmployeeController(IHttpClientFactory httpClientFactory) 
    : BaseController<ResultEmployeeDto,CreateEmployeeDto,UpdateEmployeeDto>
    ("Employees",httpClientFactory)
{
  
}

