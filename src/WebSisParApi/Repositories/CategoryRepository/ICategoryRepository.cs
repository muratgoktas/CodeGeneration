using WebSisParApi.Dto.CategoryDto;
using WebSisParApi.Dto.CategoryDtos;

namespace WebSisParApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
        void CreateCategory(CreateCategoryDto categoryDto);
        void DeleteCategory(int id);
        void UpdateCategory(UpdateCategoryDto updateCategoryDto);
        Task<GetByIdCategoryDto> GetCategoryAsync(int id);
    }
}
