using WebSisParApi.Dto.CategoryDtos;
using WebSisParApi.Dto.ProductDtos;

namespace WebSisParApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
    }
}
