using WebSisParApi.Dtos.ProductDtos;
using WebSisParApi.Dtos.ProductDtos;

namespace WebSisParApi.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
    }
}
