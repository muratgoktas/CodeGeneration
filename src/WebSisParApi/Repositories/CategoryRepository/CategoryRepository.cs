using WebApi.Models.DapperContext;
using WebSisParApi.Dto.CategoryDto;
using Dapper;

namespace WebSisParApi.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context    _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from Category";
            using (var connection = _context.CreateConnecon())
            {
                var values=await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
