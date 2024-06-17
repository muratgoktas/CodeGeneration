using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.CategoryDtos;

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
