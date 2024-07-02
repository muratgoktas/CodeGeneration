using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Repositories.BaseRepository;

namespace WebSisParApi.Repositories.CategoryRepository
{
    public interface ICategoryRepository:IBaseRepository<ResultCategoryDto,CreateCategoryDto,UpdateCategoryDto,GetByIdCategoryDto>
    {
        
    }
}
