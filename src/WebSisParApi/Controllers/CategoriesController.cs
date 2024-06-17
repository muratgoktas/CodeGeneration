using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSisParApi.Dtos.CategoryDtos;
using WebSisParApi.Repositories.CategoryRepository;

namespace WebSisParApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList() 
        {
            var values = await _categoryRepository.GetAllCategoryAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
             _categoryRepository.CreateCategory(createCategoryDto);
            return Ok("Category added.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return Ok("Category deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryRepository.UpdateCategory(updateCategoryDto);
            return Ok("Category updated.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync(int id)
        {
            var value = await _categoryRepository.GetCategoryAsync(id);
            return Ok(value);
        }

    }
}
