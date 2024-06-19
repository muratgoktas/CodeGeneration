using Dapper;
using WebApi.Models.DapperContext;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.ServiceDtos;

namespace WebSisParApi.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly Context _context;
        // ToDo : Dapper kısmı buradan başlıyor.
        // ToDo : Dapper NuGetten install et.
        public ServiceRepository(Context context)
        {
            _context = context;
        }
        public void CreateService(CreateServiceDto createServiceDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteService(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * from dbo.Services ";

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdServiceDto> GetServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateService(UpdateServiceDto updateServiceDto)
        {
            throw new NotImplementedException();
        }
    }
}
