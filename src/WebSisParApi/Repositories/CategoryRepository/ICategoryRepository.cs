using WebSisParApi.Dto.CategoryDto;

namespace WebSisParApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();
    }
}
