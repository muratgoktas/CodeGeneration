using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NuGet.Configuration;
using WebSisPar.Dtos.ProductDtos;


namespace WebSisPar.ViewComponents.Layout
{
    public class _ProductsDatasBlogItemViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApiSettings _apiSettings;


        public _ProductsDatasBlogItemViewComponentPartial(IOptions<ApiSettings> apiSettings, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _apiSettings = apiSettings.Value;
        }

        

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient(); //ToDo: Client serverdan istekte bulunacak
            //ToDO: Problem Çözüldü . Canlılya taşıdığımızda bu api adresi revize edilmesi lazım
            //ToDO: Aşağıdaki adresi sagger UI dan aldık. Ve apisetings.json na tanımladık.
            
            var responseMessage = await client.GetAsync($"{_apiSettings.BaseUrl}");


            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
