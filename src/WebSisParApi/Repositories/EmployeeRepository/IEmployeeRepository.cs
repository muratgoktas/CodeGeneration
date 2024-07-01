using WebSisParApi.Dtos.EmployeeDtos;
using WebSisParApi.Repositories.BaseRepository;

namespace WebSisParApi.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository:IBaseRepository<ResultEmployeeDto,CreateEmployeeDto,UpdateEmployeeDto,GetByIdEmployeeDto>
    {
      
    }
}
