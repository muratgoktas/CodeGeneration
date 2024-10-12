
namespace WebSisParApi.Repositories.BaseRepository
{
    public interface IBaseRepository
    {

    }
    public interface IBaseRepository<TResultDto, TCreateDto, TUpdateDto,TGetByIdDto> 
        where TResultDto : class,new()
        where TCreateDto : class,new()
        where TUpdateDto : class,new()
        where TGetByIdDto : class,new()
    

    {
        Task<List<TResultDto>> GetAllAsync();
        void Create(TCreateDto createDto);
        void Delete(int id);
        void Update(TUpdateDto updateDto);
        Task<TGetByIdDto> GetByIdAsync(int id);
    }
   
}
