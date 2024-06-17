using WebApi.Models.DapperContext;
using WebSisParApi.Dtos.CategoryDtos;
using Dapper;
using WebSisParApi.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebSisParApi.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context  _context;
        // ToDo : Dapper kısmı buradan başlıyor.
        // ToDo : Dapper NuGetten install et.
        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto categoryDto)
        {
            string query = "insert into dbo.Category (Name,Status) values(@name,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", categoryDto.Name);
            parameters.Add("@status", true);
            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteCategory(int id)
        {
            var query = "Delete from dbo.Category Where Id =@id ";
            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, new { id });

            }
        }

        public async Task<GetByIdCategoryDto> GetCategoryAsync(int id)
        {
            var query = "Select * from Category Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id",id);

            using (var connection = _context.CreateConnecon())
            {
               var values= await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from dbo.Category ";
           
            using (var connection = _context.CreateConnecon())
            {
                var values=await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async void UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var query = "Update Category set Name = @name, Status=@status Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateCategoryDto.Name);
            parameters.Add("@status", updateCategoryDto.Status);
            parameters.Add("@id", updateCategoryDto.Id);
           using(var connecion = _context.CreateConnecon())
            {
                await connecion.ExecuteAsync(query, parameters);
            }

        }
    }
}
