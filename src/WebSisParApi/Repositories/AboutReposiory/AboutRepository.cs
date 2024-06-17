using Dapper;
using WebApi.Models.DapperContext;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Dtos.AboutDtos;

namespace WebSisParApi.Repositories.AboutReposiory
{
    public class AboutRepository : IAboutRepository
    {
        private readonly Context _context;

        public AboutRepository(Context context)
        {
            _context = context;
        }

        public async void CreateAbout(CreateAboutDto createAboutDto)
        {
            string query = "insert into dbo.About (Title,Subtitle,Description,VideoLink,PictureLink01,PictureLink02,PictureLink03)" +
                " values(@title,@subtitle,@description,@pictureLink01,@pictureLink02,@pictureLink03)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createAboutDto.Title);
            parameters.Add("@subtitle", createAboutDto.Subtitle);
            parameters.Add("@description", createAboutDto.Description);
            parameters.Add("@pictureLink01", createAboutDto.PictureLink01);
            parameters.Add("@pictureLink02", createAboutDto.PictureLink02);
            parameters.Add("@pictureLink03", createAboutDto.PictureLink03);

            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteAbout(int id)
        {
            var query = "Delete from dbo.About Where Id =@id ";
            using (var connection = _context.CreateConnecon())
            {
                await connection.ExecuteAsync(query, new { id });

            }
        }

        public async Task<GetByIdAboutDto> GetAboutAsync(int id)
        {
            var query = "Select * from About Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdAboutDto>(query, parameters);
                return values;
            }
        }

        public async Task<List<ResultAboutDto>> GetAllAboutAsync()
        {
            string query = "Select * from dbo.About ";

            using (var connection = _context.CreateConnecon())
            {
                var values = await connection.QueryAsync<ResultAboutDto>(query);
                return values.ToList();
            }
        }

        public async void UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var query = "Update About set Title = @title, Subtitle=@subtitle,Description = @description"
                + "PictureLink01=@pictureLink01, PictureLink02 =@pictureLink02, PictureLink03=@pictureLink03"
                + " Where Id =@id";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateAboutDto.Title);
            parameters.Add("@subtitle", updateAboutDto.Subtitle);
            parameters.Add("@description", updateAboutDto.Description);
            parameters.Add("@pictureLink01", updateAboutDto.PictureLink01);
            parameters.Add("@pictureLink02", updateAboutDto.PictureLink02);
            parameters.Add("@pictureLink03", updateAboutDto.PictureLink03);
            parameters.Add("@id", updateAboutDto.Id);
            using (var connecion = _context.CreateConnecon())
            {
                await connecion.ExecuteAsync(query, parameters);
            }

        }
    }
}
