

using WebSisPar.Dtos.CategoryDtos;

namespace WebSisPar.Controllers;

public class CategoryController(IHttpClientFactory httpClientFactory)
    : BaseController<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    ("Categories", httpClientFactory)
{
   
   
    

}
