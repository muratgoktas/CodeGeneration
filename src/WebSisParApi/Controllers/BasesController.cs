using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSisParApi.Repositories.BaseRepository;

namespace WebSisParApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasesController <TEntity>: ControllerBase 
     where TEntity : IBaseRepository<TResultDto, TCreateDto, TUpdateDto, TGetByIdDto>
    {
        private readonly TEntity _tEntity;

        public BasesController(TEntity tEntity)
        {
            _tEntity = tEntity;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var values = await _tEntity.GetAllAsync();
            return Ok(values);

        }
        [HttpPost]
        public async Task<IActionResult> Create(TCreateDto createDto)
        {
            _tEntity.Create(createDto);
            return Ok("Created.");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _tEntity.Delete(id);
            return Ok("Deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> Update(TUpdateDto updateDto)
        {
            _tEntity.Update(updateDto);
            return Ok("Updated.");

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdEmployee(int id)
        {
            var value = await _tEntity.GetByIdAsync(id);
            return Ok(value);
        }
    }
}

namespace WebSisParApi
{
    public class TResultDto
    {
    } 
    public class TCreateDto
    {
    } public class TUpdateDto
    {
    } public class TGetByIdDto
    {
    }
}