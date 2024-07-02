using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;
using WebSisPar.Dtos.CategoryDtos;


namespace WebSisPar.Controllers;

public class BaseController<TResult, TCreate, TUpdate> : Controller
   where TResult : class, new()
   where TCreate : class, new()
   where TUpdate : class, new()
    //where TUpdate : class, new()
{

    private readonly IHttpClientFactory _httpClientFactory;
    private readonly string _getValue;


    public BaseController(string getValue, IHttpClientFactory httpClientFactory)
    {
        _getValue = getValue;
        _httpClientFactory = httpClientFactory;
    }
    public async Task<IActionResult> Index()
    {

        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync(@"https://localhost:44334/api/" + _getValue);
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<TResult>>(jsonData);
            return View(values);
        }
        return View();
    }
    #region Later look
  [HttpGet]
  public async Task<IActionResult> CreateProduct()
    {
       var client = _httpClientFactory.CreateClient();
     var responseMessage = await client.GetAsync("https://localhost:44334/api/Categories");
       var jsonData = await responseMessage.Content.ReadAsStringAsync();
        var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);

       List<SelectListItem> categoryValues = (from mcs in values.ToList()
                                               select new SelectListItem
                                              {
                                                  Text = mcs.Name,
                                                 Value = mcs.Id.ToString()

                                             }).ToList();

       ViewBag.m = categoryValues;
     return View();
   }
    #endregion


    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(TCreate tCreate)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(tCreate);
        StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PostAsync("https://localhost:44334/api/" + _getValue, stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();

    }

    public async Task<IActionResult> Delete(int id)
    {
        var client = _httpClientFactory.CreateClient();

        var responseMessage = await client.DeleteAsync($"https://localhost:44334/api/" + _getValue + "/" + $"{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }
    [HttpGet]
    public async Task<IActionResult> Update(int id)
    {
        var client = _httpClientFactory.CreateClient();
        var responseMessage = await client.GetAsync($"https://localhost:44334/api/" + _getValue + "/" + $"{id}");
        if (responseMessage.IsSuccessStatusCode)
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<TUpdate>(jsonData);
            return View(value);
        }
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Update(TUpdate tUpdate)
    {
        var client = _httpClientFactory.CreateClient();
        var jsonData = JsonConvert.SerializeObject(tUpdate);
        StringContent stringContent = new(jsonData, Encoding.UTF8, "application/json");
        var responseMessage = await client.PutAsync("https://localhost:44334/api/" + _getValue + "/", stringContent);
        if (responseMessage.IsSuccessStatusCode)
        {
            return RedirectToAction("Index");
        }
        return View();
    }

}
