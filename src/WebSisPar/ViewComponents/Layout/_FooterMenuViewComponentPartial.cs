using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebSisPar.Dtos.ServiceDtos;

namespace WebSisPar.ViewComponents.Layout
{
    public class _FooterMenuViewComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _FooterMenuViewComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44334/api/Services");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ResultServiceDtos>>(jsonData);
                return View(value);
            }
            return View();
        }
    }
}
