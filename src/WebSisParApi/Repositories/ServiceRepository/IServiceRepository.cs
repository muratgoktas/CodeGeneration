
using WebSisParApi.Dtos.ServiceDtos;

namespace WebSisParApi.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void DeleteService(int id);
        void UpdateService(UpdateServiceDto updateServiceDto);
        Task<GetByIdServiceDto> GetServiceAsync(int id);
    }
}
