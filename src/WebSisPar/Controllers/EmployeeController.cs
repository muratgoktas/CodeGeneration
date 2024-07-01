using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSisPar.Dtos.EmployeeDtos;
using static System.Net.WebRequestMethods;



namespace WebSisPar.Controllers;

public class EmployeeController(IHttpClientFactory httpClientFactory) 
    : BaseController<ResultEmployeeDto,CreateEmployeeDto,UpdateEmployeeDto>
    ("Employees",httpClientFactory)
{
  
}

