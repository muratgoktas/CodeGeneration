using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebSisParApi.Dto.CategoryDto;
using WebSisParApi.Dtos.AboutDto;
using WebSisParApi.Repositories.AboutReposiory;
using WebSisParApi.Repositories.CategoryRepository;

namespace WebSisParApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutsController(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }
        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _aboutRepository.GetAllAboutAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            _aboutRepository.CreateAbout(createAboutDto);
            return Ok("About added.");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            _aboutRepository.DeleteAbout(id);
            return Ok("About deleted.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutRepository.UpdateAbout(updateAboutDto);
            return Ok("About updated.");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutAsync(int id)
        {
            var value = await _aboutRepository.GetAboutAsync(id);
            return Ok(value);
        }
    }
}
