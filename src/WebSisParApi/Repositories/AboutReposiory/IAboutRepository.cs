using WebSisParApi.Dtos.AboutDtos;
using WebSisParApi.Repositories.BaseRepository;

namespace WebSisParApi.Repositories.AboutReposiory
{
    public interface IAboutRepository
    {
       
        void DeleteAbout(int id);
        Task<List<ResultAboutDto>> GetAllAboutAsync();
        void CreateAbout(CreateAboutDto createAboutDto);
        
        void UpdateAbout(UpdateAboutDto updateAboutDto);
        Task<GetByIdAboutDto> GetAboutAsync(int id);

    }
}
