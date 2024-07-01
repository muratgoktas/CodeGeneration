using Dapper;
using WebApi.Models.DapperContext;
using WebSisParApi.Dtos.EmployeeDtos;

namespace WebSisParApi.Repositories.EmployeeRepository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;
        // ToDo : Dapper kısmı buradan başlıyor.
        // ToDo : Dapper NuGetten install et.
        public EmployeeRepository(Context context)
        {
            _context = context;
        }
        public async void Create(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into dbo.Employee (Name,Title,Mail,PhoneNumber,ImageUrl,ProfilUrl,CreateDate,Status)"+
                " values(@name,@title,@mail,@phoneNumber,@imageUrl,@profilUrl,@createDate,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phoneNumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@profilUrl", createEmployeeDto.ProfilUrl);
            parameters.Add("@createDate", DateTime.UtcNow);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void Delete(int id)
        {
            var query = "Delete from Employee Where Id =@id ";
            var parameters = new DynamicParameters();
            parameters.Add("@id",id);
            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllAsync()
        {
            string query = "Select * from dbo.Employee";

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdEmployeeDto> GetByIdAsync(int id)
        {
            var query = "Select * from Employee Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void Update(UpdateEmployeeDto updateEmployeeDto)
        {
           
            var query = "Update Employee set Name = @name,Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,"+
                "ProfilUrl=@profilUrl,UpdateDate=@UpdateDate, Status=@status Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@profilUrl", updateEmployeeDto.ProfilUrl);
            parameters.Add("@status", true);
            parameters.Add("@updateDate", DateTime.UtcNow);
            parameters.Add("@id", updateEmployeeDto.Id);
            using (var connecion = _context.CreateConnecon())
            {
                await connecion.ExecuteAsync(query, parameters);
            }
        }
    }
}
