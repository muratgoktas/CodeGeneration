using WebSisParApi.Dto.CategoryDto;
using WebSisParApi.Dto.CategoryDtos;
using WebSisParApi.Dtos.AboutDto;

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
