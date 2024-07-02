using Microsoft.AspNetCore.Mvc;
using WebSisPar.Dtos.ProductDtos;

namespace WebSisPar.Controllers;

public class ProductController(IHttpClientFactory httpClientFactory)
: BaseController<ResultProductDto, CreateProductDto, UpdateProductDto>
("Products", httpClientFactory)
{
    #region Later look
    //[HttpGet]
    //public async Task<IActionResult> CreateProduct()
    //{
    //    var client = _httpClientFactory.CreateClient();
    //    var responseMessage = await client.GetAsync("https://localhost:44334/api/Categories");
    //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
    //    var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

    //    List<SelectListItem> categoryValues = (from mcs in values.ToList()
    //                                           select new SelectListItem
    //                                           {
    //                                               Text = mcs.Name,
    //                                               Value = mcs.Id.ToString()

    //                                           }).ToList();

    //    ViewBag.m = categoryValues;
    //    return View();
    //}
    #endregion
   
}
