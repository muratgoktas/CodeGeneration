using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.AboutDtos;

namespace WebSisParApi.Repositories.AboutReposiory
{
    public interface IAboutRepository
    {
        Task<List<ResultAboutDto>> GetAllAboutAsync();
        void CreateAbout(CreateAboutDto createAboutDto);
        void DeleteAbout(int id);
        void UpdateAbout(UpdateAboutDto updateAboutDto);
        Task<GetByIdAboutDto> GetAboutAsync(int id);
    }
}
